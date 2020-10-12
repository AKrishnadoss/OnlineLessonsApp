import { Component, OnInit } from '@angular/core';
import { StudentService } from '../../../services/StudentService';
import { Student } from '../../../models/Student';


@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
})
export class StudentsComponent implements OnInit {

  students: Student[];
  loadingMessage: string;
  errorMessage: string;
  constructor(private _studentService: StudentService) {

  }

  ngOnInit() {
    this.loadingMessage = "";
    this.errorMessage = "";
    this.getAllStudents();
  }


  getAllStudents() {
    this.loadingMessage = "Loading students please wait";
    this.errorMessage = "";
    this._studentService.getAllStudents()
      .subscribe(
        result => {
          this.students = result;
          this.loadingMessage = "";
        },
        err => {
          console.log(err);
          this.errorMessage = err.statusText;
        }
      )
  }
  
}
