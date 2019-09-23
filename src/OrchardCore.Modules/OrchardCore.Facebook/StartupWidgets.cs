using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using OrchardCore.DisplayManagement.Descriptors;
using OrchardCore.Facebook.Widgets;
using OrchardCore.Facebook.Widgets.Drivers;
using OrchardCore.Facebook.Widgets.Handlers;
using OrchardCore.Facebook.Widgets.Models;
using OrchardCore.Facebook.Widgets.Services;
using OrchardCore.Facebook.Widgets.Settings;
using OrchardCore.Modules;

namespace OrchardCore.Facebook
{
    [Feature(FacebookConstants.Features.Widgets)]
    public class StartupWidgets : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDataMigration, WidgetMigrations>();
            services.AddScoped<IShapeTableProvider, LiquidShapes>();

            services.AddContentPart<FacebookPluginPart>()
                .WithDisplayDriver<FacebookPluginPartDisplayDriver>()
                .WithHandler<FacebookPluginPartHandler>();

            services.AddScoped<IContentTypePartDefinitionDisplayDriver, FacebookPluginPartSettingsDisplayDriver>();
        }
    }

}
