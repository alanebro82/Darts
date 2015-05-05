using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts.UI.View.Generic
{
    /// <summary>
    /// Class that describes a page
    /// </summary>
    public class PageDescriptor
    {
        public
        PageDescriptor( string aLocalizedTitle, Type aPageType )
        {
            LocalizedTitle = aLocalizedTitle;
            PageType = aPageType;
        }

        /// <summary>
        /// Title of the page
        /// </summary>
        public string LocalizedTitle
        {
            get;
        }

        /// <summary>
        /// Type represented by the page
        /// </summary>
        public Type PageType
        {
            get;
        }
    }
}
