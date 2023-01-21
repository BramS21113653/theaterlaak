import React, { Component } from 'react';
import './Home.css';

export class Groepen extends Component {
  static displayName = Groepen.name;

  constructor(props) {
    super(props);
    this.state = {
        groepId: "4",
        naam: "werkt",
        website: "werkt",
        voorstellingen: null
      };

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(event) {
    this.setState({groepId: event.target.groepId});
    this.setState({naam: event.target.naam});
    this.setState({website: event.target.website});
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
        <label>
        id:
          <input name='groepId' type="text" value={this.state.groepId} onChange={this.handleChange} />
        </label><label>
        Groepsnaam:
          <input name='naam' type="text" value={this.state.naam} onChange={this.handleChange} />
          </label><label>
        Website:
          <input name='website' type="text" value={this.state.website} onChange={this.handleChange} />
        </label>
        <input type="submit" value="Submit" />
      </form>
    );
  }
}
