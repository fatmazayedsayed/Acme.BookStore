using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp.FeatureManagement;

namespace Acme.BookStore
{
    public class MyCustomerService : DomainService
    {
        private readonly IFeatureManager _featureManager;

        public MyCustomerService(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }

        public async Task EnableStockManagementAsync(Guid tenantId)
        {
            await _featureManager.SetForTenantAsync(
                tenantId,
                "MyApp.StockManagement",
                "true"
            );
        }
    }

}
