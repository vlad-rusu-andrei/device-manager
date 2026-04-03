import { Component } from '@angular/core';
import { User } from '../../interfaces/user';
import { Observable } from 'rxjs';
import { UserService } from '../../services/user-service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-users',
  imports: [CommonModule],
  templateUrl: './users.html',
  styleUrl: './users.css',
})
export class UserComponent {
    
      // async call so data arrives correctly to be rendered
      users$!: Observable<User[]>;
  
      constructor(private deviceService : UserService) {}
  
      ngOnInit(): void {
        this.users$ = this.deviceService.getUsers();
      }
}
