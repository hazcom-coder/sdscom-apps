using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SDSComApps.Models;

namespace SDSComApps.ViewComponents
{
    /// <summary>
    /// 
    /// </summary>
    public class PhraseSelectorViewComponent : ViewComponent
    {

        /// <summary>
        /// 
        /// </summary>
        public PhraseSelectorViewComponent()
        {

        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetTopEntitiesAsync(3);

            items.ToList();

            return View(items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityCount"></param>
        /// <returns></returns>
        public Task<IList<Entity>> GetTopEntitiesAsync(int entityCount)
        {
            return Task.Run(() =>
            {
                IList<Entity> e = new List<Entity>();

                e.Add(new Entity { ID = 1, EntityName = "Abc" });
                e.Add(new Entity { ID = 2, EntityName = "SDSDFSF" });
                e.Add(new Entity { ID = 3, EntityName = "qweqweq" });
                e.Add(new Entity { ID = 1, EntityName = "Abc" });
                e.Add(new Entity { ID = 2, EntityName = "SDSDFSF" });
                e.Add(new Entity { ID = 3, EntityName = "qweqweq" });

                return e;
            });
        }


    }
}
