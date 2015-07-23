// /* Task Description */

//  *	//Create a module for working with books
//  *	//The module must provide the following functionalities:
//  *	//Add a new book to category
//  *	//Each book has unique title, author and ISBN
//  *	//It must return the newly created book with assigned ID
//  *	If the category is missing, it must be automatically created
//  *	List all books
//  *	Books are sorted by ID
//  *	This can be done by author, by category or all
//  *	List all categories
//  *	Categories are sorted by ID
//  *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
//  *	When adding a book/category, the ID is generated automatically
//  *	Add validation everywhere, where possible
//  *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
//  *	Author is any non-empty string
//  *	Unique params are Book title and Book ISBN
//  *	Book ISBN is an unique code that contains either 10 or 13 digits
//  *	If something is not valid - throw Error


function solve() {
    var library = (function() {
        var categories = [];
        var books = [];
        var result;
        var self = this;

        function addBook(book) {
            var currentBook = {
                ID: books.length+1,
                title: book.title,
                ISBN: book.ISBN,
                author: book.author
            };
            books.push(currentBook);
            return currentBook;
        }

        function listBooks() {
            return books;
        }

        function addCategory(category) {
            categories.push(category);
            return result;
        }

        function listCategories() {
            return categories;
        }
        result = {
            books: {
                listBooks: listBooks,
                add: addBook
            },
            categories: listCategories,

        };
        return result;

    })();
    return library;
}
// var bookStore = solve();

// console.log(bookStore.addBook("Cool").addBook("GUMA").listBooks());
module.exports = solve;