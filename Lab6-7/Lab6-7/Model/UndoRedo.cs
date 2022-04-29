using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_7.Model
{
    class UndoRedo
    {
        private static readonly List<(string, object?)> undoList = new();
        private static readonly List<(string, object?)> 
            redoList = new();

        public static void AddToUndo(string action, object? someValue)
        {
        undoList.Add((action,someValue));
        redoList.Clear();
        }

        public static void AddToRedo(string action, object? someValue)
        {
            redoList.Add((action,someValue));
        }

        public static void Redo()
        {

            if (redoList.Count == 0) return;
            var temp = redoList.Last();
            switch (temp.Item1)
            {
                case "Add":
                    Shop.Add((Product) temp.Item2);
                    AddToUndo("Remove", (Product)temp.Item2);
                    break;
                case "Remove":
                    Shop.DeleteLast();
                    AddToUndo("Add",(Product)temp.Item2);
                    break;
            }
            if (redoList.Count == 0) return;
            redoList.RemoveAt(redoList.Count-1);
        }

        public static void Undo()
        {
            if (undoList.Count == 0) return;
            var temp = undoList.Last();
            switch (temp.Item1)
            {
                case "Add":
                    Shop.Add((Product)temp.Item2);
                    AddToRedo("Remove", (Product)temp.Item2);
                    break;
                case "Remove":
                    Shop.Delete((Product)temp.Item2);
                    AddToRedo("Add", (Product)temp.Item2);
                    break;
            }
            if (undoList.Count == 0) return;
            undoList.RemoveAt(undoList.Count-1);
        }
    }
}
