import { NgModule } from "@angular/core";
import { TripComponent } from "./trip/trip.component";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { ModalDescricaoModule } from "../modal-descricao/modal-descricao.module";


@NgModule({
    declarations: [ TripComponent ],
    exports: [ TripComponent ],
    imports: [
        BrowserModule,
        HttpClientModule
       ] , 
})

export class TripsModule { }