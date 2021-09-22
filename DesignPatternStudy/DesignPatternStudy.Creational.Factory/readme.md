Factory is a creation design pattern which is used to create different implementation objects of the same type
        
Example:
  If you have to design Logger API (class) which can log to different mediums like:
    - In memory data structure (MEMORY)
    - File on disk (FILE)
    - Database (DB)
    - Remote storage (REMOTE_SERVICE) 
    
  based on this article:
    https://medium.com/@kousiknath/design-patterns-different-approaches-to-use-factory-pattern-to-choose-objects-dynamically-at-run-71449bceecef
  and this one:
    https://medium.com/swlh/factory-pattern-without-switch-this-is-how-it-should-be-done-cd895e356f44