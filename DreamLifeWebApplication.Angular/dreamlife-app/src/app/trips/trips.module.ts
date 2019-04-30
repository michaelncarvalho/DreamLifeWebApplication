import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { ModalDescricaoModule } from "../modal-descricao/modal-descricao.module";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { TripComponent } from "./trip/trip.component";
import { MenuComponent } from "src/menu/menu.component";
import { MenuModule } from "src/menu/menu.module";


@NgModule({
    declarations: [ TripComponent, MenuComponent],
    exports: [ TripComponent],
    entryComponents: [TripComponent, MenuComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        NgbModule,
        ModalDescricaoModule
       ] , 
})

export class TripsModule { }