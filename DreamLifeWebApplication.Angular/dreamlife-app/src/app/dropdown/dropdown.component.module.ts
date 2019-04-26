import { NgModule } from "@angular/core";
import { DropDownComponent } from './dropdown.component'
import { AppMaterialModule } from "../app-material/app-material.module";
import { BrowserModule } from "@angular/platform-browser";



@NgModule({
    declarations: [ DropDownComponent ],
    exports: [ DropDownComponent ],
    imports: [
        BrowserModule,
        AppMaterialModule
      ],
})

export class DropDownModule { }