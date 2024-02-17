// defining a class called comment.
class Comment
    {
        // Declaring the variables as public variables(responsibilities of the class).
        public string Name { get; set; }
        public string Text { get; set; }
        // Comment constructor
        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }