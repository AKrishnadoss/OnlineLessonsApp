import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Student } from '../models/student';


@Injectable()
export class StudentService {
  constructor(private _http: HttpClient) { }


  getAllStudents() {
    return this._http.get<Student[]>('/api/student');
  }

  getStudentById(id: number) {
    return this._http.get<Student[]>('/api/student/'+id);
  }

 
}
