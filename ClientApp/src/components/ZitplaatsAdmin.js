import React, { Component } from 'react';
import './Home.css';

export class ZitplaatsAdmin extends Component {
    static displayName = ZitplaatsAdmin.name;
  
    constructor(props) {
      super(props);
      this.state = {
        //   zitplaatsId: null,
          stoelnummer: "1",
          rangnummer: "1",
        //   segmentZitplaats: 1,
          zaalId: null,
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
      fetch('https://localhost:7003/api/zitplaats', requestOptions)
      .then((response) => response.json())
      .then((data) => console.log(data));
  
      // alert('A name was submitted: ' + this.state.naam);
      event.preventDefault();
    }
  
    render() {
      return (
        <form onSubmit={this.handleSubmit}>
          <h1>Zitplaats toevoegen aan een zaal:</h1>
          {/* <label>
          Id:
            <input name='zitplaatsId' type="text" value={this.state.zitplaatsId} onChange={this.handleInputChange} />
          </label> */}
          <label>
          Stoelnummer:
            <input name='stoelnummer' type="text" value={this.state.stoelnummer} onChange={this.handleInputChange} />
            </label>
            <label>
            Rangnummer:
            <input name='rangnummer' type="text" value={this.state.rangnummer} onChange={this.handleInputChange} />
            </label>
            {/* <label>
            Segment van de zitplaats:
            <input name='segmentZitplaats' type="text" value={this.state.segmentZitplaats} onChange={this.handleInputChange} />
            </label> */}
            <label>
            zaalId:
            <input name='zaalId' type="text" value={this.state.zaalId} onChange={this.handleInputChange} />
            </label>
          <input type="submit" value="Submit" />
        </form>
      );
    }
}