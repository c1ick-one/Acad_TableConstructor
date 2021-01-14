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
    class UPoint    {

        public Point3d GetPoint()
        {
            Document doc =Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            PromptPointResult pr =
              ed.GetPoint("\nEnter table insertion point: ");
            if (pr.Status == PromptStatus.OK)
            {
                Point3d insPoint = pr.Value;
                return insPoint;
            }
            return pr.Value;
        }
    }
}
