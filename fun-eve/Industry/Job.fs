namespace FunEve.Industry

module Job = 
    
    // Length in seconds
    type JobLength = JobLength of int 



    type JobType = 
    | ResearchME
    | ResearchTE
    | Copy
    | Invent
    | Manufacture
    | ReverseEngineer


