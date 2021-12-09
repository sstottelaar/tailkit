using System;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Infrastructure.Packaging;

namespace TailKit.Migrations
{
    public class StarterKitPackageMigrationPlan : PackageMigrationPlan
    {
        public StarterKitPackageMigrationPlan()
            : base("TailKit")
        {
        }

        protected override void DefinePlan()
        {
            To<ImportPackageXmlMigration>(new Guid("A5F51B1D-F467-4DE8-899C-0FA09EE5E789"));
        }
    }
}