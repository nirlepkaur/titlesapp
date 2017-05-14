﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "Titles.DbContext\App.config"
//     Connection String Name: "TitleDbContext"
//     Connection String:      "Data Source=(local);Initial Catalog=Titles;Integrated Security=True;"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Titles.DbContext
{
    using System.Linq;

    #region Unit of work

    public interface ITitleDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Award> Awards { get; set; } // Award
        System.Data.Entity.DbSet<Genre> Genres { get; set; } // Genre
        System.Data.Entity.DbSet<OtherName> OtherNames { get; set; } // OtherName
        System.Data.Entity.DbSet<Participant> Participants { get; set; } // Participant
        System.Data.Entity.DbSet<StoryLine> StoryLines { get; set; } // StoryLine
        System.Data.Entity.DbSet<Title> Titles { get; set; } // Title
        System.Data.Entity.DbSet<TitleGenre> TitleGenres { get; set; } // TitleGenre
        System.Data.Entity.DbSet<TitleParticipant> TitleParticipants { get; set; } // TitleParticipant

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class TitleDbContext : System.Data.Entity.DbContext, ITitleDbContext
    {
        public System.Data.Entity.DbSet<Award> Awards { get; set; } // Award
        public System.Data.Entity.DbSet<Genre> Genres { get; set; } // Genre
        public System.Data.Entity.DbSet<OtherName> OtherNames { get; set; } // OtherName
        public System.Data.Entity.DbSet<Participant> Participants { get; set; } // Participant
        public System.Data.Entity.DbSet<StoryLine> StoryLines { get; set; } // StoryLine
        public System.Data.Entity.DbSet<Title> Titles { get; set; } // Title
        public System.Data.Entity.DbSet<TitleGenre> TitleGenres { get; set; } // TitleGenre
        public System.Data.Entity.DbSet<TitleParticipant> TitleParticipants { get; set; } // TitleParticipant

        static TitleDbContext()
        {
            System.Data.Entity.Database.SetInitializer<TitleDbContext>(null);
        }

        public TitleDbContext()
            : base("Name=TitleDbContext")
        {
        }

        public TitleDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public TitleDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public TitleDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public TitleDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AwardConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new OtherNameConfiguration());
            modelBuilder.Configurations.Add(new ParticipantConfiguration());
            modelBuilder.Configurations.Add(new StoryLineConfiguration());
            modelBuilder.Configurations.Add(new TitleConfiguration());
            modelBuilder.Configurations.Add(new TitleGenreConfiguration());
            modelBuilder.Configurations.Add(new TitleParticipantConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AwardConfiguration(schema));
            modelBuilder.Configurations.Add(new GenreConfiguration(schema));
            modelBuilder.Configurations.Add(new OtherNameConfiguration(schema));
            modelBuilder.Configurations.Add(new ParticipantConfiguration(schema));
            modelBuilder.Configurations.Add(new StoryLineConfiguration(schema));
            modelBuilder.Configurations.Add(new TitleConfiguration(schema));
            modelBuilder.Configurations.Add(new TitleGenreConfiguration(schema));
            modelBuilder.Configurations.Add(new TitleParticipantConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class FakeTitleDbContext : ITitleDbContext
    {
        public System.Data.Entity.DbSet<Award> Awards { get; set; }
        public System.Data.Entity.DbSet<Genre> Genres { get; set; }
        public System.Data.Entity.DbSet<OtherName> OtherNames { get; set; }
        public System.Data.Entity.DbSet<Participant> Participants { get; set; }
        public System.Data.Entity.DbSet<StoryLine> StoryLines { get; set; }
        public System.Data.Entity.DbSet<Title> Titles { get; set; }
        public System.Data.Entity.DbSet<TitleGenre> TitleGenres { get; set; }
        public System.Data.Entity.DbSet<TitleParticipant> TitleParticipants { get; set; }

        public FakeTitleDbContext()
        {
            Awards = new FakeDbSet<Award>("Id");
            Genres = new FakeDbSet<Genre>("Id");
            OtherNames = new FakeDbSet<OtherName>("Id");
            Participants = new FakeDbSet<Participant>("Id");
            StoryLines = new FakeDbSet<StoryLine>("Id");
            Titles = new FakeDbSet<Title>("TitleId");
            TitleGenres = new FakeDbSet<TitleGenre>("Id");
            TitleParticipants = new FakeDbSet<TitleParticipant>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TElement>(expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Award
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class Award
    {
        public int TitleId { get; set; } // TitleId
        public bool? AwardWon { get; set; } // AwardWon
        public int? AwardYear { get; set; } // AwardYear
        public string Award_ { get; set; } // Award (length: 100)
        public string AwardCompany { get; set; } // AwardCompany (length: 100)
        public int Id { get; set; } // Id (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Title pointed by [Award].([TitleId]) (Award_FK_Award_Title)
        /// </summary>
        public virtual Title Title { get; set; } // Award_FK_Award_Title
    }

    // Genre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class Genre
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child TitleGenres where [TitleGenre].[GenreId] point to this entity (TitleGenre_FK_TitleGenre_Genre)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitleGenre> TitleGenres { get; set; } // TitleGenre.TitleGenre_FK_TitleGenre_Genre

        public Genre()
        {
            TitleGenres = new System.Collections.Generic.List<TitleGenre>();
        }
    }

    // OtherName
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class OtherName
    {
        public int? TitleId { get; set; } // TitleId
        public string TitleNameLanguage { get; set; } // TitleNameLanguage (length: 100)
        public string TitleNameType { get; set; } // TitleNameType (length: 100)
        public string TitleNameSortable { get; set; } // TitleNameSortable (length: 100)
        public string TitleName { get; set; } // TitleName (length: 100)
        public int Id { get; set; } // Id (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Title pointed by [OtherName].([TitleId]) (OtherName_FK_OtherName_Title)
        /// </summary>
        public virtual Title Title { get; set; } // OtherName_FK_OtherName_Title
    }

    // Participant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class Participant
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 100)
        public string ParticipantType { get; set; } // ParticipantType (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child TitleParticipants where [TitleParticipant].[ParticipantId] point to this entity (TitleParticipant_FK_TitleParticipant_Participant)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitleParticipant> TitleParticipants { get; set; } // TitleParticipant.TitleParticipant_FK_TitleParticipant_Participant

        public Participant()
        {
            TitleParticipants = new System.Collections.Generic.List<TitleParticipant>();
        }
    }

    // StoryLine
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class StoryLine
    {
        public int TitleId { get; set; } // TitleId
        public string Type { get; set; } // Type (length: 100)
        public string Language { get; set; } // Language (length: 100)
        public string Description { get; set; } // Description (length: 1073741823)
        public int Id { get; set; } // Id (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent Title pointed by [StoryLine].([TitleId]) (StoryLine_FK_StoryLine_Title)
        /// </summary>
        public virtual Title Title { get; set; } // StoryLine_FK_StoryLine_Title
    }

    // Title
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class Title
    {
        public int TitleId { get; set; } // TitleId (Primary key)
        public string TitleName { get; set; } // TitleName (length: 100)
        public string TitleNameSortable { get; set; } // TitleNameSortable (length: 100)
        public int? TitleTypeId { get; set; } // TitleTypeId
        public int? ReleaseYear { get; set; } // ReleaseYear
        public System.DateTime? ProcessedDateTimeUtc { get; set; } // ProcessedDateTimeUTC

        // Reverse navigation

        /// <summary>
        /// Child Awards where [Award].[TitleId] point to this entity (Award_FK_Award_Title)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Award> Awards { get; set; } // Award.Award_FK_Award_Title
        /// <summary>
        /// Child OtherNames where [OtherName].[TitleId] point to this entity (OtherName_FK_OtherName_Title)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<OtherName> OtherNames { get; set; } // OtherName.OtherName_FK_OtherName_Title
        /// <summary>
        /// Child StoryLines where [StoryLine].[TitleId] point to this entity (StoryLine_FK_StoryLine_Title)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<StoryLine> StoryLines { get; set; } // StoryLine.StoryLine_FK_StoryLine_Title
        /// <summary>
        /// Child TitleGenres where [TitleGenre].[TitleId] point to this entity (TitleGenre_FK_TitleGenre_Title)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitleGenre> TitleGenres { get; set; } // TitleGenre.TitleGenre_FK_TitleGenre_Title
        /// <summary>
        /// Child TitleParticipants where [TitleParticipant].[TitleId] point to this entity (TitleParticipant_FK_TitleParticipant_Title)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TitleParticipant> TitleParticipants { get; set; } // TitleParticipant.TitleParticipant_FK_TitleParticipant_Title

        public Title()
        {
            Awards = new System.Collections.Generic.List<Award>();
            OtherNames = new System.Collections.Generic.List<OtherName>();
            StoryLines = new System.Collections.Generic.List<StoryLine>();
            TitleGenres = new System.Collections.Generic.List<TitleGenre>();
            TitleParticipants = new System.Collections.Generic.List<TitleParticipant>();
        }
    }

    // TitleGenre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class TitleGenre
    {
        public int Id { get; set; } // Id (Primary key)
        public int TitleId { get; set; } // TitleId
        public int GenreId { get; set; } // GenreId

        // Foreign keys

        /// <summary>
        /// Parent Genre pointed by [TitleGenre].([GenreId]) (TitleGenre_FK_TitleGenre_Genre)
        /// </summary>
        public virtual Genre Genre { get; set; } // TitleGenre_FK_TitleGenre_Genre
        /// <summary>
        /// Parent Title pointed by [TitleGenre].([TitleId]) (TitleGenre_FK_TitleGenre_Title)
        /// </summary>
        public virtual Title Title { get; set; } // TitleGenre_FK_TitleGenre_Title
    }

    // TitleParticipant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class TitleParticipant
    {
        public int Id { get; set; } // Id (Primary key)
        public int TitleId { get; set; } // TitleId
        public int ParticipantId { get; set; } // ParticipantId
        public bool IsKey { get; set; } // IsKey
        public string RoleType { get; set; } // RoleType (length: 100)
        public bool IsOnScreen { get; set; } // IsOnScreen

        // Foreign keys

        /// <summary>
        /// Parent Participant pointed by [TitleParticipant].([ParticipantId]) (TitleParticipant_FK_TitleParticipant_Participant)
        /// </summary>
        public virtual Participant Participant { get; set; } // TitleParticipant_FK_TitleParticipant_Participant
        /// <summary>
        /// Parent Title pointed by [TitleParticipant].([TitleId]) (TitleParticipant_FK_TitleParticipant_Title)
        /// </summary>
        public virtual Title Title { get; set; } // TitleParticipant_FK_TitleParticipant_Title
    }

    #endregion

    #region POCO Configuration

    // Award
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class AwardConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Award>
    {
        public AwardConfiguration()
            : this("dbo")
        {
        }

        public AwardConfiguration(string schema)
        {
            ToTable("Award", schema);
            HasKey(x => x.Id);

            Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsRequired();
            Property(x => x.AwardWon).HasColumnName(@"AwardWon").HasColumnType("bit").IsOptional();
            Property(x => x.AwardYear).HasColumnName(@"AwardYear").HasColumnType("int").IsOptional();
            Property(x => x.Award_).HasColumnName(@"Award").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AwardCompany).HasColumnName(@"AwardCompany").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasRequired(a => a.Title).WithMany(b => b.Awards).HasForeignKey(c => c.TitleId).WillCascadeOnDelete(false); // Award_FK_Award_Title
        }
    }

    // Genre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class GenreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
            : this("dbo")
        {
        }

        public GenreConfiguration(string schema)
        {
            ToTable("Genre", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }

    // OtherName
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class OtherNameConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OtherName>
    {
        public OtherNameConfiguration()
            : this("dbo")
        {
        }

        public OtherNameConfiguration(string schema)
        {
            ToTable("OtherName", schema);
            HasKey(x => x.Id);

            Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsOptional();
            Property(x => x.TitleNameLanguage).HasColumnName(@"TitleNameLanguage").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TitleNameType).HasColumnName(@"TitleNameType").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TitleNameSortable).HasColumnName(@"TitleNameSortable").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TitleName).HasColumnName(@"TitleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasOptional(a => a.Title).WithMany(b => b.OtherNames).HasForeignKey(c => c.TitleId).WillCascadeOnDelete(false); // OtherName_FK_OtherName_Title
        }
    }

    // Participant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class ParticipantConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Participant>
    {
        public ParticipantConfiguration()
            : this("dbo")
        {
        }

        public ParticipantConfiguration(string schema)
        {
            ToTable("Participant", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ParticipantType).HasColumnName(@"ParticipantType").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }

    // StoryLine
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class StoryLineConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StoryLine>
    {
        public StoryLineConfiguration()
            : this("dbo")
        {
        }

        public StoryLineConfiguration(string schema)
        {
            ToTable("StoryLine", schema);
            HasKey(x => x.Id);

            Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsRequired();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Language).HasColumnName(@"Language").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("ntext").IsOptional().IsMaxLength();
            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasRequired(a => a.Title).WithMany(b => b.StoryLines).HasForeignKey(c => c.TitleId).WillCascadeOnDelete(false); // StoryLine_FK_StoryLine_Title
        }
    }

    // Title
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class TitleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Title>
    {
        public TitleConfiguration()
            : this("dbo")
        {
        }

        public TitleConfiguration(string schema)
        {
            ToTable("Title", schema);
            HasKey(x => x.TitleId);

            Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TitleName).HasColumnName(@"TitleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TitleNameSortable).HasColumnName(@"TitleNameSortable").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.TitleTypeId).HasColumnName(@"TitleTypeId").HasColumnType("int").IsOptional();
            Property(x => x.ReleaseYear).HasColumnName(@"ReleaseYear").HasColumnType("int").IsOptional();
            Property(x => x.ProcessedDateTimeUtc).HasColumnName(@"ProcessedDateTimeUTC").HasColumnType("datetime").IsOptional();
        }
    }

    // TitleGenre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class TitleGenreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TitleGenre>
    {
        public TitleGenreConfiguration()
            : this("dbo")
        {
        }

        public TitleGenreConfiguration(string schema)
        {
            ToTable("TitleGenre", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsRequired();
            Property(x => x.GenreId).HasColumnName(@"GenreId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Genre).WithMany(b => b.TitleGenres).HasForeignKey(c => c.GenreId).WillCascadeOnDelete(false); // TitleGenre_FK_TitleGenre_Genre
            HasRequired(a => a.Title).WithMany(b => b.TitleGenres).HasForeignKey(c => c.TitleId).WillCascadeOnDelete(false); // TitleGenre_FK_TitleGenre_Title
        }
    }

    // TitleParticipant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.30.0.0")]
    public class TitleParticipantConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TitleParticipant>
    {
        public TitleParticipantConfiguration()
            : this("dbo")
        {
        }

        public TitleParticipantConfiguration(string schema)
        {
            ToTable("TitleParticipant", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TitleId).HasColumnName(@"TitleId").HasColumnType("int").IsRequired();
            Property(x => x.ParticipantId).HasColumnName(@"ParticipantId").HasColumnType("int").IsRequired();
            Property(x => x.IsKey).HasColumnName(@"IsKey").HasColumnType("bit").IsRequired();
            Property(x => x.RoleType).HasColumnName(@"RoleType").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IsOnScreen).HasColumnName(@"IsOnScreen").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.Participant).WithMany(b => b.TitleParticipants).HasForeignKey(c => c.ParticipantId).WillCascadeOnDelete(false); // TitleParticipant_FK_TitleParticipant_Participant
            HasRequired(a => a.Title).WithMany(b => b.TitleParticipants).HasForeignKey(c => c.TitleId).WillCascadeOnDelete(false); // TitleParticipant_FK_TitleParticipant_Title
        }
    }

    #endregion

}
// </auto-generated>

