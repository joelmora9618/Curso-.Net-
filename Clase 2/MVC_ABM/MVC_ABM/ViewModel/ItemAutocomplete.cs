using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ABM.ViewModel
{
    public class ItemAutocomplete
    {
        private long id;
        private string value;
        private string label;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }
    }
}