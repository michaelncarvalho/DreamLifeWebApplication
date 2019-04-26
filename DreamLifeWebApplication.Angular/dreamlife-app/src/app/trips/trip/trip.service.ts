import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Trip } from "./trip";

const API = 'http://localhost:50214';

@Injectable({ providedIn: 'root' })
export class TripService {

    private dateFilter: string = "2019-05-28T00:00:00";
    constructor(private http: HttpClient) { }

    getTrips(){
        let params = new HttpParams().set('CidadeId', '1');
        return this.http
        .get<Trip[]>(API + '/trips/Hotels', {params: params});        
    }
}