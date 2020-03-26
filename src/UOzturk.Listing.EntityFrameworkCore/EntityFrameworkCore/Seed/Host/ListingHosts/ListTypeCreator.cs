using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UOzturk.Listing.EntityFrameworkCore.EntityFrameworkCore.Seed.Host.ListingHosts
{
    public class ListTypeCreator
    {
        private readonly ListingDbContext _context;

        public ListTypeCreator(ListingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateGeneralListType();
            CreateMovieListType();
            CreateTvSeriesListType();
            CreateAnimeListType();
            CreateMangaListType();
            CreateTodoListType();
        }

        private void CreateGeneralListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.DefaultListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.DefaultUserCreatedListName };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }

        private void CreateMovieListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.MovieListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.MovieListType };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }

        private void CreateTvSeriesListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.TvSeriesListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.TvSeriesListType };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }

        private void CreateAnimeListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.AnimeListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.AnimeListType };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }

        private void CreateMangaListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.MangaListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.MangaListType };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }

        private void CreateTodoListType()
        {
            var defaultListType = _context.ListType.IgnoreQueryFilters().FirstOrDefault(e => e.Name == ListingConsts.TodoListType);
            if (defaultListType == null)
            {
                defaultListType = new List.ListTypeEntity { Name = ListingConsts.TodoListType };
                _context.ListType.Add(defaultListType);
                _context.SaveChanges();
            }
        }
    }
}
