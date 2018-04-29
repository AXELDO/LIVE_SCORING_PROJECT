"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
//Imports statements 
var User_1 = require("../Model/User");
var core_1 = require("@angular/core");
//Attrribute metadata
var UserComponent = /** @class */ (function () {
    function UserComponent() {
        this.CurrentUser = new User_1.User();
    }
    UserComponent = __decorate([
        core_1.Component({
            selector: "user-ui",
            templateUrl: "../js/Angular/UI/User.html"
        })
        // User component exposing the user model
    ], UserComponent);
    return UserComponent;
}());
exports.UserComponent = UserComponent;
//# sourceMappingURL=UserComponent.js.map