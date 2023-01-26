import React, { Component } from 'react';
import {Routes, Route, useNavigate} from 'react-router-dom';
import { ApplicationUserAdmin } from './ApplicationUserAdmin';
import { GroepenAdmin } from './GroepenAdmin';
import { ZaalAdmin } from './ZaalAdmin';

export const AdminPanel = (props) => {
    const navigate = useNavigate();

    const navigateToZaalAdmin = () => {
        // 👇️ navigate to /contacts
        navigate('/zaaladmin');
    };

    const navigateToGroepenAdmin = () => {
        // 👇️ navigate to /contacts
        navigate('/groepenadmin');
    };

    const navigateToApplicationUserAdmin = () => {
        // 👇️ navigate to /contacts
        navigate('/applicationuseradmin');
    };
    return (
        <div>
            <p><button onClick={navigateToZaalAdmin}>Zaal Wijzigen</button></p>
            <p><button onClick={navigateToGroepenAdmin}>Groep Wijzigen</button></p>
            <p><button onClick={navigateToApplicationUserAdmin}>ApplicationUser Wijzigen</button></p>
            <div>
                <Routes>
                    <Route 
                    path="/zaaladmin" 
                    // require auth
                    element={<ZaalAdmin />} 
                    />
                    <Route 
                    path="/groepenadmin" 
                    // require auth
                    element={<GroepenAdmin />} 
                    />
                    <Route 
                    path="/applicationuseradmin" 
                    // require auth
                    element={<ApplicationUserAdmin />} 
                    />
                </Routes>
            </div>
        </div> 
    );
}
