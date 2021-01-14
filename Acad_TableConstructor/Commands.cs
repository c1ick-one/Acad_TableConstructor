using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Acad_TableConstructor
{
    public class Commands
    {
        [CommandMethod("CRT")]
        static public void CreateTable()
        {


            Point3d pt = (new UPoint()).GetPoint();
           // string [,] str = (new Information()).GetInformation();
            string[][] str = (new Information()).GetFromCSV("C:\\Test.csv");
            Table tb = (new UTable()).CreateTable(str,pt);



            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;
            Transaction tr = doc.TransactionManager.StartTransaction();
                using (tr)
                {
                    BlockTable bt =
                      (BlockTable)tr.GetObject(
                        doc.Database.BlockTableId,
                        OpenMode.ForRead
                     );
                    BlockTableRecord btr =
                      (BlockTableRecord)tr.GetObject(
                        bt[BlockTableRecord.ModelSpace],
                        OpenMode.ForWrite
                      );
                    btr.AppendEntity(tb);
                    tr.AddNewlyCreatedDBObject(tb, true);
                    tr.Commit();
                }
        }
    }
}

