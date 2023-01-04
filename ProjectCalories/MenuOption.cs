using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalories
{/// <summary>
/// Меню опций
/// </summary>
    public class MenuOption
    {
        /// <summary>
        /// Название пункта меню
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Ссылка на метод действия меню
        /// </summary>
        public Action Action { get; set; }
    }
}
