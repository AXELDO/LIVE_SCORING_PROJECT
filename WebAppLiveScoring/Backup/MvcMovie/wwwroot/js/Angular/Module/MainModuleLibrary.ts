import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from "@angular/forms";
import { UserComponent } from '../Component/UserComponent';

@NgModule({
    imports: [BrowserModule,
        FormsModule],
    declarations: [UserComponent],
    bootstrap: [UserComponent]
})
export class MainModuleLibrary { }