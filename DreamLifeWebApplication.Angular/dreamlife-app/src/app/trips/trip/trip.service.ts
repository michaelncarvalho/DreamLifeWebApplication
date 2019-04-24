import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Trip } from "./trip";

const API = 'http://localhost:50214';

@Injectable({ providedIn: 'root' })
export class TripService {


    constructor(private http: HttpClient) { }

    getTrips(){
        return this.http
        .get<Trip[]>(API + '/trips/Viagens');        
    }
}