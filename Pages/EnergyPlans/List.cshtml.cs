using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andromeda.Core;
using Andromina.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AndromedaWeb2.Pages.EnergyPlans
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IEnergyPlanData energyPlanList;

        public IEnumerable<EnergyPlan> EnergyPlans { get; set; }


        //public string Message { get; set; }
        //public string AppSettingMessage { get; set; }

        public ListModel(IConfiguration config, IEnergyPlanData energyPlanList)
        {
            this.config = config;
            this.energyPlanList = energyPlanList;
        }

        public void OnGet()
        {
            EnergyPlans = energyPlanList.GetAll();
            //Message = "I added a property to the page";
            //AppSettingMessage = config["AppSettingsMessage"];

        }
    }
}