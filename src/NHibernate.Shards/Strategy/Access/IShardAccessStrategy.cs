using System.Collections.Generic;
using NHibernate.Shards.Strategy.Exit;

namespace NHibernate.Shards.Strategy.Access
{
	public interface IShardAccessStrategy
	{
		T Apply<T>(IEnumerable<IShard> shards, IShardOperation<T> operation, IExitStrategy<T> exitStrategy);
	}
}