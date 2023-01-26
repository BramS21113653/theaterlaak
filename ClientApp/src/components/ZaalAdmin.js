import React, { Component } from 'react';
import './Home.css';

export class ZaalAdmin extends Component {
  static displayName = ZaalAdmin.name;

  constructor(props) {
    super(props);
    this.state = {
        zaalId: "1",
        zaalnummer: "1",
        aantalZitplaatsen: "50",
        gelegenheid: null,
        ticket: null,
        zitplaats: null,
        boeking: null
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
    fetch('https://localhost:7003/api/zaal', requestOptions)
    .then((response) => response.json())
    .then((data) => console.log(data));

    // alert('A name was submitted: ' + this.state.naam);
    event.preventDefault();
  }

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <h1>Zaal toevoegen:</h1>
        <label>
        Id:
          <input name='zaalId' type="text" value={this.state.zaalId} onChange={this.handleInputChange} />
        </label><label>
        Nummer:
          <input name='zaalnummer' type="text" value={this.state.zaalnummer} onChange={this.handleInputChange} />
          </label><label>
        Aantal zitplaatsen:
          <input name='aantalZitplaatsen' type="text" value={this.state.aantalZitplaatsen} onChange={this.handleInputChange} />
        </label>
        <input type="submit" value="Submit" />
      </form>
    );
  }
}
