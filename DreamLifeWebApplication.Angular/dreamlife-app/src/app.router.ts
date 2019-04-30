import { Routes, RouterModule } from '@angular/router'
import { TripComponent } from './app/trips/trip/trip.component';
import { CadastroCidadeComponent } from './app/cadastro-cidade/cadastro-cidade.component';
import { MenuComponent } from './menu/menu.component';
import { CadastroHotelComponent } from './app/cadastro-hotel/cadastro-hotel.component';
import { VisualizarPaginaComponent } from './app/visualizar-pagina/visualizar-pagina.component';

const routes: Routes = [
    //localhost:4200
    {
        path: '',
        component: TripComponent           
    },
    //Cadastro cidade
    {
        path: 'cadastro-cidade',
        component: CadastroCidadeComponent
    },
    //Cadastro hotel
    {
        path: 'cadastro-hotel',
        component: CadastroHotelComponent
    },
     //Visualizar pagina
     {
        path: 'visualizar-pagina',
        component: VisualizarPaginaComponent
    }

];

export const RoutingModule = RouterModule.forRoot(routes);