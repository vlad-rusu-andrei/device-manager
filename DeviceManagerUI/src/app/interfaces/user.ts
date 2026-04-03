interface Location{
    city : string;
    street : string;
    number : string;
}

export interface User{
    id : number;
    name : string;
    location : Location;
}