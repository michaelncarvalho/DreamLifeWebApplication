import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Trip } from "./trip";

//const API = 'http://localhost:50214';
const API = 'http://177.105.34.12/DreamLifeWeb_api/trips/';


@Injectable({ providedIn: 'root' })
export class TripService {

    private dateFilter: string = "2019-05-28T00:00:00";
    
    constructor(private http: HttpClient) { }    
    
    getTrips(selectedValue: string){
        console.log(selectedValue);
        let params = new HttpParams().set('CidadeId', selectedValue);
        return this.http
        .get<Trip[]>(API + 'Hotels', {params: params});        
    }

}