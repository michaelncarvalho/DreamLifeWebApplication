import { Routes, RouterModule } from '@angular/router'
import { TripComponent } from './app/trips/trip/trip.component';
import { DescricaoHotelComponent } from './app/descricao-hotel/descricao-hotel.component';

const routes: Routes = [
    //localhost:4200
    {
        path: '',
        component: TripComponent
    },
    //Descrição Hotel
    {
        path: 'descricao-hotel',
        component: DescricaoHotelComponent
    }   
];
export const RoutingModule = RouterModule.forRoot(routes);