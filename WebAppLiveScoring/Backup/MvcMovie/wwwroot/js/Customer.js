"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Dal_1 = require("./Dal");
var Customer = /** @class */ (function () {
    function Customer() {
    }
    Customer.prototype.Add = function () {
        var dal = new Dal_1.Dal();
        dal.Add();
    };
    Customer.prototype.TestCustomerClass = function () {
        alert("Test customer OK !");
    };
    return Customer;
}());
exports.Customer = Customer;
//# sourceMappingURL=Customer.js.map