﻿using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialMarch.Menu
{
    public class MenuSelection
    {
        DepartmentService e;
        
        public MenuSelection() 
        {
            e = new DepartmentService();
        }
        public void Run()
        {

        }

        public int InputChoice()
        {
            var choice = 0;
            return choice;
        }
    }
}
