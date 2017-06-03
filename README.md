# GlobalX code challenge

This is a simple console based .net application which 
 --> Takes as a parameter a string that represents a text file containing a list of names.
 --> Orders the names by last name followed by first name.
 --> Creates a new text file called <input-file-name>-sorted.txt with the list of sorted names.

## Classes

### MainClass
This is the starting point of application where static void main method has been implemented. Main methods creates an object of other classes to fulfill the requirements.

### ReadFile
This is a generic class which can be used to read any text file. It has method called ReadFileToList() which reads all the lines of file and stores it in the list object.

### ConvertLineToObject
This is a generic class which can be used to convert list of strings to list of objects. In this case list of strings is converted into list of Person objects. As this is a generic class it can be used with any type of objects.

### SortList
This is a generic class for sorting any list of objects based on given property of an object. It can be used with list of any type of objects. Sorting can be done in ascending as well as descending order.

### ConvertObjectToLine
This is a generic class which can be used to convert list of objects to list of strings. In this case list of person objetcs is converted into list of strings. As this is a generic class it can be used with any type of objects.

### WriteFile
This is a generic class which can be used to write in the text file. It has method called WriteListToFile() which writes list of strings into a text file.

### Person
This is an entity class to crate an person object in the list.


## Coding Consideration

 --> SOLID Principle
 --> Seperation of concerns

Based on the SOLID principle and Seperation of Converns every class has single resonsiblity. All these classes can are open to extension but close to modification. ReadFile, WriteFile, SortList, ConvertLineToObject and ConvertObjectToLine use Liskov substitution principle as they are generic class and can be used with any type of entity objects.