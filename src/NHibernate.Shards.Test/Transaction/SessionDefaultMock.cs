﻿namespace NHibernate.Shards.Test.Transaction
{
	using System;
	using System.Data;
	using System.Linq.Expressions;
	using NHibernate.Engine;
	using NHibernate.Stat;
	using NHibernate.Type;

	public class SessionDefaultMock: ISession
	{
		public virtual void Dispose()
		{
			throw new NotSupportedException();
		}

		public virtual void Flush()
		{
			throw new NotSupportedException();
		}

		public virtual IDbConnection Disconnect()
		{
			throw new NotSupportedException();
		}

		public virtual void Reconnect()
		{
			throw new NotSupportedException();
		}

		public virtual void Reconnect(IDbConnection connection)
		{
			throw new NotSupportedException();
		}

		public virtual IDbConnection Close()
		{
			throw new NotSupportedException();
		}

		public virtual void CancelQuery()
		{
			throw new NotSupportedException();
		}

		public virtual bool IsDirty()
		{
			throw new NotSupportedException();
		}

		public virtual object GetIdentifier(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual bool Contains(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Evict(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual object Load(System.Type theType, object id, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual object Load(string entityName, object id, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual object Load(System.Type theType, object id)
		{
			throw new NotSupportedException();
		}

		public virtual T Load<T>(object id, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual T Load<T>(object id)
		{
			throw new NotSupportedException();
		}

		public virtual object Load(string entityName, object id)
		{
			throw new NotSupportedException();
		}

		public virtual void Load(object obj, object id)
		{
			throw new NotSupportedException();
		}

		public virtual void Replicate(object obj, ReplicationMode replicationMode)
		{
			throw new NotSupportedException();
		}

		public virtual void Replicate(string entityName, object obj, ReplicationMode replicationMode)
		{
			throw new NotSupportedException();
		}

		public virtual object Save(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Save(object obj, object id)
		{
			throw new NotSupportedException();
		}

		public virtual object Save(string entityName, object obj)
		{
			throw new NotSupportedException();
		}

		public void Save(string entityName, object obj, object id)
		{
			throw new NotImplementedException();
		}

		public virtual void SaveOrUpdate(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void SaveOrUpdate(string entityName, object obj)
		{
			throw new NotSupportedException();
		}

		public void SaveOrUpdate(string entityName, object obj, object id)
		{
			throw new NotImplementedException();
		}

		public virtual void Update(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Update(object obj, object id)
		{
			throw new NotSupportedException();
		}

		public virtual void Update(string entityName, object obj)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		/// Update the persistent instance associated with the given identifier.
		/// </summary>
		/// <param name="entityName">The Entity name.</param><param name="obj">a detached instance containing updated state </param><param name="id">Identifier of persistent instance</param>
		/// <remarks>
		/// If there is a persistent instance with the same identifier,
		///             an exception is thrown. This operation cascades to associated instances
		///             if the association is mapped with <tt>cascade="save-update"</tt>.
		/// </remarks>
		public void Update(string entityName, object obj, object id)
		{
			throw new NotImplementedException();
		}

		public virtual object Merge(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual object Merge(string entityName, object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Persist(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Persist(string entityName, object obj)
		{
			throw new NotSupportedException();
		}

		public virtual object SaveOrUpdateCopy(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual object SaveOrUpdateCopy(object obj, object id)
		{
			throw new NotSupportedException();
		}

		public virtual void Delete(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Delete(string entityName, object obj)
		{
			throw new NotSupportedException();
		}

		public virtual int Delete(string query)
		{
			throw new NotSupportedException();
		}

		public virtual int Delete(string query, object value, IType type)
		{
			throw new NotSupportedException();
		}

		public virtual int Delete(string query, object[] values, IType[] types)
		{
			throw new NotSupportedException();
		}

		public virtual void Lock(object obj, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual void Lock(string entityName, object obj, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual void Refresh(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual void Refresh(object obj, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual LockMode GetCurrentLockMode(object obj)
		{
			throw new NotSupportedException();
		}

		public ITransaction BeginTransaction()
		{
			return BeginTransaction(IsolationLevel.Unspecified);
		}

		public virtual ITransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			throw new NotSupportedException();
		}

		public virtual ICriteria CreateCriteria<T>() where T : class
		{
			throw new NotSupportedException();
		}

		public virtual ICriteria CreateCriteria<T>(string alias) where T : class
		{
			throw new NotSupportedException();
		}

		public virtual ICriteria CreateCriteria(System.Type persistentClass)
		{
			throw new NotSupportedException();
		}

		public virtual ICriteria CreateCriteria(System.Type persistentClass, string alias)
		{
			throw new NotSupportedException();
		}

		public virtual ICriteria CreateCriteria(string entityName)
		{
			throw new NotSupportedException();
		}

		public virtual ICriteria CreateCriteria(string entityName, string alias)
		{
			throw new NotSupportedException();
		}

		public virtual IQueryOver<T, T> QueryOver<T>() where T : class
		{
			throw new NotSupportedException();
		}

		public virtual IQueryOver<T, T> QueryOver<T>(Expression<Func<T>> alias) where T : class
		{
			throw new NotSupportedException();
		}

		public virtual IQuery CreateQuery(string queryString)
		{
			throw new NotSupportedException();
		}

		public virtual IQuery CreateFilter(object collection, string queryString)
		{
			throw new NotSupportedException();
		}

		public virtual IQuery GetNamedQuery(string queryName)
		{
			throw new NotSupportedException();
		}

		public virtual ISQLQuery CreateSQLQuery(string queryString)
		{
			throw new NotSupportedException();
		}

		public virtual void Clear()
		{
			throw new NotSupportedException();
		}

		public virtual object Get(System.Type clazz, object id)
		{
			throw new NotSupportedException();
		}

		public virtual object Get(System.Type clazz, object id, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual object Get(string entityName, object id)
		{
			throw new NotSupportedException();
		}

		public virtual T Get<T>(object id)
		{
			throw new NotSupportedException();
		}

		public virtual T Get<T>(object id, LockMode lockMode)
		{
			throw new NotSupportedException();
		}

		public virtual string GetEntityName(object obj)
		{
			throw new NotSupportedException();
		}

		public virtual IFilter EnableFilter(string filterName)
		{
			throw new NotSupportedException();
		}

		public virtual IFilter GetEnabledFilter(string filterName)
		{
			throw new NotSupportedException();
		}

		public virtual void DisableFilter(string filterName)
		{
			throw new NotSupportedException();
		}

		public virtual IMultiQuery CreateMultiQuery()
		{
			throw new NotSupportedException();
		}

		public virtual ISession SetBatchSize(int batchSize)
		{
			throw new NotSupportedException();
		}

		public virtual ISessionImplementor GetSessionImplementation()
		{
			throw new NotSupportedException();
		}

		public virtual IMultiCriteria CreateMultiCriteria()
		{
			throw new NotSupportedException();
		}

		public virtual ISession GetSession(EntityMode entityMode)
		{
			throw new NotSupportedException();
		}

		public virtual EntityMode ActiveEntityMode
		{
			get { throw new NotSupportedException(); }
		}

		public virtual FlushMode FlushMode
		{
			get { throw new NotSupportedException(); }
			set { throw new NotSupportedException(); }
		}

		public virtual CacheMode CacheMode
		{
			get { throw new NotSupportedException(); }
			set { throw new NotSupportedException(); }
		}

		public virtual ISessionFactory SessionFactory
		{
			get { throw new NotSupportedException(); }
		}

		public virtual IDbConnection Connection
		{
			get { throw new NotSupportedException(); }
		}

		public virtual bool IsOpen
		{
			get { throw new NotSupportedException(); }
		}

		public virtual bool IsConnected
		{
			get { throw new NotSupportedException(); }
		}

		public virtual ITransaction Transaction
		{
			get { throw new NotSupportedException(); }
		}

		public virtual ISessionStatistics Statistics
		{
			get { throw new NotSupportedException(); }
		}

		public virtual IQuery CreateQuery(IQueryExpression queryExpression)
		{
			throw new NotSupportedException();
		}

		public bool DefaultReadOnly
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public bool IsReadOnly(object entityOrProxy)
		{
			throw new NotSupportedException();
		}

		public T Merge<T>(string entityName, T entity) where T : class
		{
			throw new NotSupportedException();
		}

		public T Merge<T>(T entity) where T : class
		{
			throw new NotSupportedException();
		}

		public IQueryOver<T, T> QueryOver<T>(string entityName, Expression<Func<T>> alias) where T : class
		{
			throw new NotSupportedException();
		}

		public IQueryOver<T, T> QueryOver<T>(string entityName) where T : class
		{
			throw new NotSupportedException();
		}

		public void SetReadOnly(object entityOrProxy, bool readOnly)
		{
			throw new NotSupportedException();
		}
	}
}
