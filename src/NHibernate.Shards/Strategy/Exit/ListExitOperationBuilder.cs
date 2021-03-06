﻿using System.Collections.Generic;

namespace NHibernate.Shards.Strategy.Exit
{
	using NHibernate.Shards.Util;

	/// <summary>
	/// A builder of <see cref="ListExitOperation"/> instances.
	/// </summary>
	public class ListExitOperationBuilder
	{
		private readonly List<SortOrder> orders = new List<SortOrder>();

		/// <summary>
		/// Maximum number of results requested by the client.
		/// Defaults to <c>null</c>.
		/// </summary>
		public int? MaxResults { get; set; }

		/// <summary>
		/// Index of the first result requested by the client.
		/// Defaults to <c>0</c>.
		/// </summary>
		public int FirstResult { get; set; }

		/// <summary>
		/// Indication whether client requests removal of duplicate results.
		/// Defaults to <c>false</c>.
		/// </summary>
		public bool Distinct { get; set; }

		/// <summary>
		/// Optional aggregation function to be applied to the results.
		/// </summary>
		public AggregationFunc Aggregation { get; set; }

		/// <summary>
		/// Creates empty <see cref="ListExitOperationBuilder"/> instance.
		/// </summary>
		public ListExitOperationBuilder()
		{}

		/// <summary>
		/// Creates clone of another <see cref="ListExitOperationBuilder"/> instance.
		/// </summary>
		/// <param name="other">The builder to clone.</param>
		public ListExitOperationBuilder(ListExitOperationBuilder other)
		{
			Preconditions.CheckNotNull(other);

			this.orders.AddRange(other.orders);
			this.MaxResults = other.MaxResults;
			this.FirstResult = other.FirstResult;
			this.Distinct = other.Distinct;
			this.Aggregation = other.Aggregation;
		}

		/// <summary>
		/// Sort order to be applied to the results.
		/// </summary>
		public IList<SortOrder> Orders
		{
			get { return this.orders; }
		}

		/// <summary>
		/// Creates new <see cref="ListExitOperation"/> with settings matching those 
		/// that are currently defined on this builder instance.
		/// </summary>
		/// <returns>A new <see cref="ListExitOperation"/> with settings matching those 
		/// that are currently defined on this builder instance.</returns>
		public ListExitOperation BuildListOperation()
		{
			return new ListExitOperation(this.MaxResults, this.FirstResult, this.Distinct, this.Aggregation, BuildComparer());
		}

		public ListExitOperationBuilder Clone()
		{
			return new ListExitOperationBuilder(this);
		}

		private IComparer<object> BuildComparer()
		{
			return this.orders.Count > 0
				? new SortOrderComparer(this.orders)
				: null;
		}
	}
}
