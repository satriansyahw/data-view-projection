using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MyInventory.DomainModels.Controllers
{
    partial class InventoryController
    {
        public InventoryController()
        {
            db.AfterSaveChangesDelegate = (context, affectedRows) =>
                {
                    if (affectedRows > 0)
                    {
                        string imagePath = HttpContext.Current.Server.MapPath("~/images");

                        if (db.Files != null && db.Files.Count() > 0)
                        {
                            foreach (var file in db.Files)
                            {
                                file.Save(Path.Combine(imagePath, file.Name == "Thumbnail" ? "thumbs" : "large"));
                            }
                        }
                    }
                };
        }
    }
}