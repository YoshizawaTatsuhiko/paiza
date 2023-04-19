using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Maze
{
    public class MazeCreator_Extend
    {
        /// <summary>2次元配列の迷路情報</summary>
        private int[,] _maze;
        /// <summary>迷路の横幅</summary>
        public int _width { get; }
        /// <summary>迷路の縦幅</summary>
        public int _height { get; }

        /// <summary>乱数生成用</summary>
        private Random _random;
        /// <summary>現在拡張中の壁情報を保持</summary>
        private Stack<Cell> _currentWallCells;
        /// <summary>壁の拡張を行う開始セルの情報</summary>
        private List<Cell> _startCells;

        // コンストラクタ
        public MazeCreator_Extend(int width, int height)
        {
            // 5未満のサイズや偶数では生成できない
            if (width < 5 || height < 5)
                throw new ArgumentOutOfRangeException();
            if (width % 2 == 0) width++;
            if (height % 2 == 0) height++;

            // 迷路情報を初期化
            _width = width;
            _height = height;
            _maze = new int[width, height];
            _startCells = new List<Cell>();
            _currentWallCells = new Stack<Cell>();
            _random = new Random();
        }

        public int[,] CreateMaze()
        {
            // 各マスの初期設定を行う
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    // 外周のみ壁にしておき、開始候補として保持
                    if (x * y == 0 || x == _width - 1 || y == _height - 1)
                    {
                        _maze[x, y] = Wall;
                    }
                    else
                    {
                        _maze[x, y] = Path;
                        // 外周ではない偶数座標を壁伸ばし開始点にしておく
                        if (x % 2 == 0 && y % 2 == 0)
                        {
                            // 開始候補座標
                            _startCells.Add(new Cell(x, y));
                        }
                    }
                }
            }

            // 壁が拡張できなくなるまでループ
            while (_startCells.Count > 0)
            {
                // ランダムに開始セルを取得し、開始候補から削除
                var index = _random.Next(_startCells.Count);
                var cell = _startCells[index];
                _startCells.RemoveAt(index);
                var x = cell.X;
                var y = cell.Y;

                // すでに壁の場合は何もしない
                if (_maze[x, y] == Path)
                {
                    // 拡張中の壁情報を初期化
                    _currentWallCells.Clear();
                    ExtendWall(x, y);
                }
            }
            return _maze;
        }

        /// <summary>指定座標から壁を生成拡張する</summary>
        private void ExtendWall(int x, int y)
        {
            // 伸ばすことができる方向(1マス先が通路で2マス先まで範囲内)
            // 2マス先が壁で自分自身の場合、伸ばせない
            var directions = new List<Direction>();
            if (_maze[x, y - 1] == Path && !IsCurrentWall(x, y - 2))
                directions.Add(Direction.Up);
            if (_maze[x + 1, y] == Path && !IsCurrentWall(x + 2, y))
                directions.Add(Direction.Right);
            if (_maze[x, y + 1] == Path && !IsCurrentWall(x, y + 2))
                directions.Add(Direction.Down);
            if (_maze[x - 1, y] == Path && !IsCurrentWall(x - 2, y))
                directions.Add(Direction.Left);

            // ランダムに伸ばす(2マス)
            if (directions.Count > 0)
            {
                // 壁を作成(この地点から壁を伸ばす)
                SetWall(x, y);

                // 伸ばす先が通路の場合は拡張を続ける
                var isPath = false;
                var dirIndex = _random.Next(directions.Count);
                switch (directions[dirIndex])
                {
                    case Direction.Up:
                        isPath = (_maze[x, y - 2] == Path);
                        SetWall(x, --y);
                        SetWall(x, --y);
                        break;
                    case Direction.Right:
                        isPath = (_maze[x + 2, y] == Path);
                        SetWall(++x, y);
                        SetWall(++x, y);
                        break;
                    case Direction.Down:
                        isPath = (_maze[x, y + 2] == Path);
                        SetWall(x, ++y);
                        SetWall(x, ++y);
                        break;
                    case Direction.Left:
                        isPath = (_maze[x - 2, y] == Path);
                        SetWall(--x, y);
                        SetWall(--x, y);
                        break;
                }
                if (isPath)
                {
                    // 既存の壁に接続できていない場合は拡張続行
                    ExtendWall(x, y);
                }
            }
            else
            {
                // すべて現在拡張中の壁にぶつかる場合、バックして再開
                var beforeCell = _currentWallCells.Pop();
                ExtendWall(beforeCell.X, beforeCell.Y);
            }
        }

        /// <summary>壁を拡張する</summary>
        private void SetWall(int x, int y)
        {
            _maze[x, y] = Wall;
            if (x % 2 == 0 && y % 2 == 0)
            {
                _currentWallCells.Push(new Cell(x, y));
            }
        }

        /// <summary>拡張中の座標かどうか判定</summary>
        private bool IsCurrentWall(int x, int y)
        {
            return _currentWallCells.Contains(new Cell(x, y));
        }

        /// <summary>デバッグ用処理</summary>
        /// <param name="maze"></param>
        public static void DebugPrint(int[,] maze)
        {
            Console.WriteLine($"Width: {maze.GetLength(0)}");
            Console.WriteLine($"Height: {maze.GetLength(1)}");
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                for (int x = 0; x < maze.GetLength(0); x++)
                {
                    Console.Write(maze[x, y] == Wall ? "■" : "　");
                }
                Console.WriteLine();
            }
        }

        // 通路・壁情報
        const int Path = 0;
        const int Wall = 1;

        // セル情報
        private struct Cell
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Cell(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // 方向
        private enum Direction
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3
        }
    }
}