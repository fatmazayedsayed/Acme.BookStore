using Acme.BookStore.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace Acme.BookStore
{
    public class MyFeatureDefinitionProvider : FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var myGroup = context.AddGroup("MyApp");

            myGroup.AddFeature(
                "MyApp.StockManagement",
                defaultValue: "false",
                displayName: L("StockManagement"),
                isVisibleToClients: true,
                valueType: new ToggleStringValueType());
            myGroup.AddFeature(
               "MyApp.BookManagement",
               defaultValue: "false",
               displayName: L("BookManagement"),
               isVisibleToClients: true,
               valueType: new ToggleStringValueType());
            myGroup.AddFeature(
                "MyApp.MaxBookCount",
                defaultValue: "2",
                displayName: L("MaxBookCount"),
                valueType: new FreeTextStringValueType(
                    new NumericValueValidator()));
        }

        private ILocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }

}
