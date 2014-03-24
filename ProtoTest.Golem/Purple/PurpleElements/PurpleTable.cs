﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;

namespace ProtoTest.Golem.Purple.PurpleElements
{
    public class PurpleTable : PurpleElementBase
    {
        public PurpleTable(string name, string locatorPath) : base(name, locatorPath)
        {

        }

        public string GetValue(int row, int column)
        {
            string somenonsense = "";
            object basePattern;
            if (PurpleElement.TryGetCurrentPattern(TablePattern.Pattern, out basePattern))
            {
                TablePattern gridItem = (BasePattern) basePattern as TablePattern;
                if (gridItem != null)
                {
                    var tableitem = gridItem.GetItem(row, column);
                    somenonsense = tableitem.Current.Name;
                }

            }
            return somenonsense;
        }

    }
}
