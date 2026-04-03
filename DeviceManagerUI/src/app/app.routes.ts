import { Routes } from '@angular/router';
import { DeviceComponent } from './components/devices/devices';
import { HomeComponent } from './components/home/home';
import { UserComponent } from './components/users/users';

export const routes: Routes = [
    { path : '', component: HomeComponent},
    { path : 'users', component: UserComponent},
    { path: 'devices', component: DeviceComponent}
];
