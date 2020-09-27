using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            books.Sort(new BookComparator());
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex = -1;

            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }

            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex < this.books.Count)
                {
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}