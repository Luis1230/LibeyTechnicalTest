import { LibeyUserService } from 'src/app/core/service/libeyuser/libeyuser.service';
import { LibeyUser } from './../../../entities/libeyuser';
import { UbigeoService } from './../../../core/service/ubigeo/ubigeo.service';
import swal from 'sweetalert2';
import { Component, OnInit } from '@angular/core';
import { DocumenttypeService } from 'src/app/core/service/documenttype/documenttype.service';
import { DocumentType } from 'src/app/entities/documenttype';
import { Region } from 'src/app/entities/region';
import { Provincia } from 'src/app/entities/provincia';
import { Ubigeo } from 'src/app/entities/ubigeo';

@Component({
  selector: 'app-usermaintenance',
  templateUrl: './usermaintenance.component.html',
  styleUrls: ['./usermaintenance.component.css']
})
export class UsermaintenanceComponent implements OnInit {
  documentTypeLst: DocumentType[] = []; // Variable para almacenar los datos
  documentTypeId : string='';
  regionList: Region[] = []; // Variable para almacenar los datos
  provinciaList: Provincia[] = []; // Variable para almacenar los datos
  ubigeoList: Ubigeo[] = []; // Variable para almacenar los datos
  ubigeoListSelect : string='';

  formData: LibeyUser =  {
    documentTypeId: '',
    documentNumber: '',
    name: '',
    fathersLastName: '',
    mothersLastName: '',
    address: '',
    regionCode: '',
    provinceCode: '',
    ubigeoCode: '',
    phone: '',
    email: '',
    password: '' ,
    active:true   
  };

	constructor(private documenttypeService: DocumenttypeService,
              private ubigeoService: UbigeoService,
              private libeyUserService: LibeyUserService
  ) {}

  ngOnInit(): void {
		this.documenttypeService.FindAllDocumentsType().subscribe({
      next: (data) => {
        this.documentTypeLst = data; // Asignar los datos a la lista
        console.log(data); // Verifica los datos en la consola
      },
      error: (err) => {
        console.error('Error al obtener la lista', err);
      },
		});

    this.ubigeoService.FindAllRegion().subscribe({
      next: (data) => {
        this.regionList = data; // Asignar los datos a la lista
        console.log(data); // Verifica los datos en la consola
      },
      error: (err) => {
        console.error('Error al obtener la lista de regiones', err);
      },
		});
	}

  obtenerProvincia(): void {    
    this.ubigeoService.FindAllProvince(this.formData.regionCode).subscribe({
      next: (data) => {
        this.provinciaList = data; // Asignar los datos a la lista
        console.log(data); // Verifica los datos en la consola
      },
      error: (err) => {
        console.error('Error al obtener la lista de provincias', err);
      },
		});
  }
  
  obtenerUbigeo(): void {  
    this.ubigeoService.FindAllUbigeo(this.formData.provinceCode).subscribe({
      next: (data) => {
        this.ubigeoList = data; // Asignar los datos a la lista
        console.log(data); // Verifica los datos en la consola
      },
      error: (err) => {
        console.error('Error al obtener la lista de ubigeos', err);
      },
		});
  }
  
  obtenerUbigeoo(): void { 
    console.log(this.formData.ubigeoCode); // Verifica los datos en la consola

  }
  
  guardarUser(){
    console.log(this.formData); // Verifica los datos en la consola
    // swal.fire("Oops!", "Something went wrong!", "error");  

    this.libeyUserService.SaveUser(this.formData).subscribe({
      next: (data) => {
        console.log(data); // Verifica los datos en la consola
        swal.fire("Exitoso", "Usuario guardado con exito!", "success");  
        this.limpiarFormulario();
      },
      error: (err) => {
        swal.fire("Oops!", "Ocurrio un error al guardar el usuario.", "error");  
      },
		});
  }

  limpiarFormulario(): void {
    this.formData =  {
      documentTypeId: '',
      documentNumber: '',
      name: '',
      fathersLastName: '',
      mothersLastName: '',
      address: '',
      regionCode: '',
      provinceCode: '',
      ubigeoCode: '',
      phone: '',
      email: '',
      password: '' ,
      active:true   
    };
  }
}