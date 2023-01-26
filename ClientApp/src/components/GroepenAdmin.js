import React, { Component } from 'react';
import './Home.css';

export class GroepenAdmin extends Component {
  static displayName = GroepenAdmin.name;

  constructor(props) {
    super(props);
    this.state = {
        groepId: "4",
        naam: "werkt",
        website: "werkt",
        voorstellingen: null
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
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(this.state)
    };
    fetch('https://localhost:7003/api/Groep', requestOptions)
    .then((response) => response.json())
    .then((data) => console.log(data));

    // alert('A name was submitted: ' + this.state.naam);
    event.preventDefault();
  }

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <h1>Groep toevoegen:</h1>
        <label>
        id:
          <input name='groepId' type="text" value={this.state.groepId} onChange={this.handleInputChange} />
        </label><label>
        Groepsnaam:
          <input name='naam' type="text" value={this.state.naam} onChange={this.handleInputChange} />
          </label><label>
        Website:
          <input name='website' type="text" value={this.state.website} onChange={this.handleInputChange} />
        </label>
        <input type="submit" value="Submit" />
      </form>
    );
  }
}
