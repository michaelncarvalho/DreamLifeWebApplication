import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { TripComponent } from "./trip/trip.component";
import { MenuComponent } from "src/menu/menu.component";
import { MenuModule } from "src/menu/menu.module";
import { MenuDescricaoComponent } from "../menu-descricao/menu-descricao.component";
import { AppMaterialModule } from "../app-material/app-material.module";


@NgModule({
    declarations: [ TripComponent, MenuDescricaoComponent],
    exports: [ TripComponent],
    entryComponents: [TripComponent, MenuDescricaoComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        NgbModule,
        AppMaterialModule
       ] , 
})

export class TripsModule { }