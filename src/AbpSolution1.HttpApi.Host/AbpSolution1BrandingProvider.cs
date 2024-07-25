using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSolution1;

[Dependency(ReplaceServices = true)]
public class AbpSolution1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpSolution1";
}
