using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Acme.BookStore.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Features;

namespace Acme.BookStore
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreAppService : ApplicationService
    {
        protected BookStoreAppService()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
        
    }
}
