using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Acad_TableConstructor
{
    class UTable
    {
        public Table CreateTable(string [,] tableInformation, Point3d insPoint)
        {
            tableInformation.GetLength(0);
            Table tb = new Table();
            int numRows = tableInformation.GetLength(0);
            int numColumns = tableInformation.GetLength(1);
            tb.SetSize(numRows, numColumns);
            tb.Position = insPoint;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    tb.Cells[i, j].TextString = tableInformation[i, j];
                }
            }
            return tb;
        }
        public Table CreateTableFrom2dArray(string[][] tableInformation, Point3d insPoint)
        {
            tableInformation.GetLength(0);
            Table tb = new Table();
            int numRows = tableInformation.GetLength(0);
            int numColumns = tableInformation.GetLength(1);
            tb.SetSize(numRows, numColumns);
            tb.Position = insPoint;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    tb.Cells[i, j].TextString = tableInformation[i, j];
                }
            }
            return tb;
        }

    }
}
