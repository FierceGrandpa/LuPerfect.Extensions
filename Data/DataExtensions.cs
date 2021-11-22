using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace LuPerfect
{
    public static partial class DataExtensions
    {
        public static DbContext DetectChangesLazyLoading(this DbContext context, bool enabled)
        {
            context.ChangeTracker.AutoDetectChangesEnabled = enabled;

            context.ChangeTracker.LazyLoadingEnabled = enabled;

            context.ChangeTracker.QueryTrackingBehavior = enabled
                ? QueryTrackingBehavior.TrackAll
                : QueryTrackingBehavior.NoTracking;

            return context;
        }

        public static DbSet<T> CommandSet<T>(this DbContext context) where T : class
            => context.DetectChangesLazyLoading(true).Set<T>();

        public static IQueryable<T> QuerySet<T>(this DbContext context) where T : class
            => context.DetectChangesLazyLoading(false).Set<T>();

        // Source: https://stackoverflow.com/a/18553786
        public static List<T> ToListReadUncommitted<T>(this IQueryable<T> query)
        {
            using var scope = new TransactionScope(
                TransactionScopeOption.Required,
                new TransactionOptions
                {
                    IsolationLevel = IsolationLevel.ReadUncommitted
                });
            var toReturn = query.ToList();
            scope.Complete();
            return toReturn;
        }

        // Source: https://stackoverflow.com/a/18553786
        public static int CountReadUncommitted<T>(this IQueryable<T> query)
        {
            using var scope = new TransactionScope(
                TransactionScopeOption.Required,
                new TransactionOptions
                {
                    IsolationLevel = IsolationLevel.ReadUncommitted
                });
            var toReturn = query.Count();
            scope.Complete();
            return toReturn;
        }
    }
}