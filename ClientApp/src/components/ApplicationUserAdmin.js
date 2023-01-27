import React, { Component } from 'react';
import './Home.css';

export class ApplicationUserAdmin extends Component {
  static displayName = ApplicationUserAdmin.name;

  constructor(props) {
    super(props);
    this.state = {
        Id: "1",
        groepId: "1"
      };

    this.handleInputChange = this.handleInputChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleInputChange(event) {
    const target = event.target;
    const value = target.value;
    const name = target.name;

    this.setState({
      [name]: value
    });
  }

  handleSubmit(event) {
    const requestOptions = {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(this.state)
    };
    fetch('https://localhost:7003/api/ApplicationUser', requestOptions)
    .then((response) => response.json())
    .then((data) => console.log(data));

    // alert('A name was submitted: ' + this.state.naam);
    event.preventDefault();
  }

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <h1>Acteur toevoegen aan een groep of de groep van een acteur wijzigen: </h1>
        <label>
        Id van de acteur:
          <input name='Id' type="text" value={this.state.Id} onChange={this.handleInputChange} />
        </label><label>
        Id van de groep:
          <input name='groepId' type="text" value={this.state.groepId} onChange={this.handleInputChange} />
          </label>
        <input type="submit" value="Submit" />
      </form>
    );
  }
}