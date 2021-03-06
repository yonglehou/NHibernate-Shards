using System.Collections.Generic;

namespace NHibernate.Shards.LoadBalance
{
	/// <summary>
	/// Helpful base class for ShardLoadBalancer implementations.
	/// </summary>
	public abstract class BaseShardLoadBalancer : BaseHasShardIdList , IShardLoadBalancer
	{
		protected BaseShardLoadBalancer(IEnumerable<ShardId> shardIds): base(shardIds)
		{
		}

		protected BaseShardLoadBalancer()
		{
		}

		/// <summary>
		/// the next ShardId
		/// </summary>
		public ShardId NextShardId
		{
			get { return ShardIds[NextIndex]; }
		}
		
		/// <summary>
		/// the index of the next ShardId we should return
		/// </summary>
		protected abstract int NextIndex { get; }
	}
}