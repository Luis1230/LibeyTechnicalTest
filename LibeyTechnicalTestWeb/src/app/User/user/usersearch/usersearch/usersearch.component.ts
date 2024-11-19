import { Component, OnInit } from '@angular/core';
import { LibeyUserService } from "src/app/core/service/libeyuser/libeyuser.service";
import { LibeyUser } from "src/app/entities/libeyuser";

@Component({
  selector: 'app-usersearch',
  templateUrl: './usersearch.component.html',
  styleUrls: ['./usersearch.component.css']
})
export class UsersearchComponent implements OnInit {
  userLst: LibeyUser[] = []; // Variable para almacenar los datos
  numeroDocumento: string = ''; // Variable para almacenar el texto ingresado

	constructor(private libeyUserService: LibeyUserService) {}

  ngOnInit(): void {
		this.libeyUserService.FindAllUsers("0").subscribe({
      next: (data) => {
        this.userLst = data; // Asignar los datos a la lista
        console.log(data); // Verifica los datos en la consola
      },
      error: (err) => {
        console.error('Error al obtener la lista', err);
      },
		});
	}

  searchUsers():void{
    if(this.numeroDocumento == ''){
      this.numeroDocumento = '0';
    }

    this.libeyUserService.FindAllUsers(this.numeroDocumento).subscribe({
      next: (data) => {
        this.userLst = data; // Asignar los datos a la lista
      },
      error: (err) => {
        console.error('Error al obtener la lista', err);
      },
		});
  }

}
