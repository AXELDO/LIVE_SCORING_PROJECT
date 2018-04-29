
//Imports statements 
import { User } from '../Model/User'
import { Component } from "@angular/core"

//Attrribute metadata

@Component({
    selector: "user-ui",
    templateUrl: "../js/Angular/UI/User.html"

})

// User component exposing the user model
export class UserComponent {
    CurrentUser: User = new User();

}