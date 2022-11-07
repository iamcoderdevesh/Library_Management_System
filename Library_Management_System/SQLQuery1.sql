select Books_records.Book_Name,Books_records.Book_Price,
Return_books.Student_Name,Return_books.Student_ID, Return_books.Issue_Date,Return_books.Return_Date,Return_books.Fine
from Books_records full outer join Return_books on Books_records.Book_ID = Return_books.Book_ID  

