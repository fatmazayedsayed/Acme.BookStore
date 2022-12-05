using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace Acme.BookStore.Web
{
    public class MyProjectNameMainToolbarContributor : IToolbarContributor
    {
        public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            //if (context.Toolbar.Name == LeptonXLiteToolbars.Main)
            //{
            //    context.Toolbar.Items.Add(new ToolbarItem(typeof(MyDesktopComponent)));
            //}

            //if (context.Toolbar.Name == LeptonXLiteToolbars.MainMobile)
            //{
            //    context.Toolbar.Items.Add(new ToolbarItem(typeof(MyMobileComponent)));
            //}
        }
    }

}
